<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponseBody\courseDTOS;

use AlibabaCloud\Tea\Model;

class classrooms extends Model
{
    /**
     * @description 课堂唯一标识
     *
     * @var string
     */
    public $targetId;

    /**
     * @description 交互信息
     *
     * @var string
     */
    public $interactInfo;
    protected $_name = [
        'targetId'     => 'targetId',
        'interactInfo' => 'interactInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->targetId) {
            $res['targetId'] = $this->targetId;
        }
        if (null !== $this->interactInfo) {
            $res['interactInfo'] = $this->interactInfo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return classrooms
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targetId'])) {
            $model->targetId = $map['targetId'];
        }
        if (isset($map['interactInfo'])) {
            $model->interactInfo = $map['interactInfo'];
        }

        return $model;
    }
}
