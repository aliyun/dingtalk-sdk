<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAssistantMessageResponseBody extends Model
{
    /**
     * @var string
     */
    public $assistantId;

    /**
     * @var int
     */
    public $createdAt;

    /**
     * @var string
     */
    public $id;

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
        'assistantId' => 'assistantId',
        'createdAt' => 'createdAt',
        'id' => 'id',
        'object' => 'object',
        'role' => 'role',
        'runId' => 'runId',
        'threadId' => 'threadId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
        }
        if (null !== $this->createdAt) {
            $res['createdAt'] = $this->createdAt;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
     * @return CreateAssistantMessageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['createdAt'])) {
            $model->createdAt = $map['createdAt'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
