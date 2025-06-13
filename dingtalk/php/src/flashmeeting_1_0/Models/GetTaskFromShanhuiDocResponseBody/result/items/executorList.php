<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetTaskFromShanhuiDocResponseBody\result\items;

use AlibabaCloud\Tea\Model;

class executorList extends Model
{
    /**
     * @var string
     */
    public $executorId;

    /**
     * @var int
     */
    public $statusStage;

    /**
     * @var string
     */
    public $subTaskKey;
    protected $_name = [
        'executorId' => 'executorId',
        'statusStage' => 'statusStage',
        'subTaskKey' => 'subTaskKey',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->executorId) {
            $res['executorId'] = $this->executorId;
        }
        if (null !== $this->statusStage) {
            $res['statusStage'] = $this->statusStage;
        }
        if (null !== $this->subTaskKey) {
            $res['subTaskKey'] = $this->subTaskKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return executorList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['executorId'])) {
            $model->executorId = $map['executorId'];
        }
        if (isset($map['statusStage'])) {
            $model->statusStage = $map['statusStage'];
        }
        if (isset($map['subTaskKey'])) {
            $model->subTaskKey = $map['subTaskKey'];
        }

        return $model;
    }
}
