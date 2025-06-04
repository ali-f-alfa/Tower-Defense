# Unity build environment
FROM unityci/editor:ubuntu-2019.4.9f1-base-3.1.0

# Set working directory inside the container
WORKDIR /workspace

# Copy the Unity project
COPY TowerDefense/ ./TowerDefense/

# Default command opens a bash shell
CMD ["/bin/bash"]
