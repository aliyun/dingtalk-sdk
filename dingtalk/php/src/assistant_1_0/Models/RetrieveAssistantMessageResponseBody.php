<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class RetrieveAssistantMessageResponseBody extends Model
{
    /**
     * @var string
     */
    public $assisantId;

    /**
     * @var mixed[]
     */
    public $content;

    /**
     * @var int
     */
    public $createdAt;

    /**
     * @var string
     */
    public $id;

    /**
     * @var mixed[]
     */
    public $metadata;

    /**
     * @var string
     */
    public $object;

    /**
     * @var string
     */
    public $role;

    /**
     * @var string
     */
    public $runId;

    /**
     * @var string
     */
    public $threadId;
    protected $_name = [
        'assisantId' => 'assisantId',
        'content' => 'content',
        'createdAt' => 'createdAt',
        'id' => 'id',
        'metadata' => 'metadata',
        'object' => 'object',
        'role' => 'role',
        'runId' => 'runId',
        'threadId' => 'threadId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->assisantId) {
            $res['assisantId'] = $this->assisantId;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->createdAt) {
            $res['createdAt'] = $this->createdAt;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->metadata) {
            $res['metadata'] = $this->metadata;
        }
        if (null !== $this->object) {
            $res['object'] = $this->object;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->runId) {
            $res['runId'] = $this->runId;
        }
        if (null !== $this->threadId) {
            $res['threadId'] = $this->threadId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RetrieveAssistantMessageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assisantId'])) {
            $model->assisantId = $map['assisantId'];
        }
        if (isset($map['content'])) {
            if (!empty($map['content'])) {
                $model->content = $map['content'];
            }
        }
        if (isset($map['createdAt'])) {
            $model->createdAt = $map['createdAt'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['metadata'])) {
            $model->metadata = $map['metadata'];
        }
        if (isset($map['object'])) {
            $model->object = $map['object'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['runId'])) {
            $model->runId = $map['runId'];
        }
        if (isset($map['threadId'])) {
            $model->threadId = $map['threadId'];
        }

        return $model;
    }
}
