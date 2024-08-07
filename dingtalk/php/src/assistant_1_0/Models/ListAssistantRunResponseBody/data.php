<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\ListAssistantRunResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $assistantId;

    /**
     * @var int
     */
    public $cancelledAt;

    /**
     * @var int
     */
    public $completedAt;

    /**
     * @var int
     */
    public $createdAt;

    /**
     * @var int
     */
    public $expiresAt;

    /**
     * @var int
     */
    public $failedAt;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $lastErrorMsg;

    /**
     * @var mixed[]
     */
    public $metadata;

    /**
     * @var string
     */
    public $object;

    /**
     * @var int
     */
    public $startedAt;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $threadId;
    protected $_name = [
        'assistantId'  => 'assistantId',
        'cancelledAt'  => 'cancelledAt',
        'completedAt'  => 'completedAt',
        'createdAt'    => 'createdAt',
        'expiresAt'    => 'expiresAt',
        'failedAt'     => 'failedAt',
        'id'           => 'id',
        'lastErrorMsg' => 'lastErrorMsg',
        'metadata'     => 'metadata',
        'object'       => 'object',
        'startedAt'    => 'startedAt',
        'status'       => 'status',
        'threadId'     => 'threadId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
        }
        if (null !== $this->cancelledAt) {
            $res['cancelledAt'] = $this->cancelledAt;
        }
        if (null !== $this->completedAt) {
            $res['completedAt'] = $this->completedAt;
        }
        if (null !== $this->createdAt) {
            $res['createdAt'] = $this->createdAt;
        }
        if (null !== $this->expiresAt) {
            $res['expiresAt'] = $this->expiresAt;
        }
        if (null !== $this->failedAt) {
            $res['failedAt'] = $this->failedAt;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->lastErrorMsg) {
            $res['lastErrorMsg'] = $this->lastErrorMsg;
        }
        if (null !== $this->metadata) {
            $res['metadata'] = $this->metadata;
        }
        if (null !== $this->object) {
            $res['object'] = $this->object;
        }
        if (null !== $this->startedAt) {
            $res['startedAt'] = $this->startedAt;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->threadId) {
            $res['threadId'] = $this->threadId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['cancelledAt'])) {
            $model->cancelledAt = $map['cancelledAt'];
        }
        if (isset($map['completedAt'])) {
            $model->completedAt = $map['completedAt'];
        }
        if (isset($map['createdAt'])) {
            $model->createdAt = $map['createdAt'];
        }
        if (isset($map['expiresAt'])) {
            $model->expiresAt = $map['expiresAt'];
        }
        if (isset($map['failedAt'])) {
            $model->failedAt = $map['failedAt'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['lastErrorMsg'])) {
            $model->lastErrorMsg = $map['lastErrorMsg'];
        }
        if (isset($map['metadata'])) {
            $model->metadata = $map['metadata'];
        }
        if (isset($map['object'])) {
            $model->object = $map['object'];
        }
        if (isset($map['startedAt'])) {
            $model->startedAt = $map['startedAt'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['threadId'])) {
            $model->threadId = $map['threadId'];
        }

        return $model;
    }
}
