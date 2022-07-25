<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result\list_;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result\list_\operationRecords\attachments;
use AlibabaCloud\Tea\Model;

class operationRecords extends Model
{
    /**
     * @description 评论附件
     *
     * @var attachments[]
     */
    public $attachments;

    /**
     * @description 操作类型
     *
     * @var string
     */
    public $operationType;

    /**
     * @description 评论
     *
     * @var string
     */
    public $remark;

    /**
     * @description 操作结果
     *
     * @var string
     */
    public $result;

    /**
     * @description 操作时间戳
     *
     * @var int
     */
    public $timestamp;

    /**
     * @description 操作人staffId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'attachments'   => 'attachments',
        'operationType' => 'operationType',
        'remark'        => 'remark',
        'result'        => 'result',
        'timestamp'     => 'timestamp',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachments) {
            $res['attachments'] = [];
            if (null !== $this->attachments && \is_array($this->attachments)) {
                $n = 0;
                foreach ($this->attachments as $item) {
                    $res['attachments'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operationType) {
            $res['operationType'] = $this->operationType;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return operationRecords
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachments'])) {
            if (!empty($map['attachments'])) {
                $model->attachments = [];
                $n                  = 0;
                foreach ($map['attachments'] as $item) {
                    $model->attachments[$n++] = null !== $item ? attachments::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operationType'])) {
            $model->operationType = $map['operationType'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
