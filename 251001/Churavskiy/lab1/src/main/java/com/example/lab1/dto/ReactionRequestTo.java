package com.example.lab1.dto;

public record ReactionRequestTo(
        Long id,
        Long topicId,
        String content
) {
}
