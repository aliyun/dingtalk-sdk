<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleByTimeSchoolResponseBody\result;

use AlibabaCloud\Tea\Model;

class classrooms extends Model
{
    /**
     * @var string
     */
    public $interactInfo;

    /**
     * @var string
     */
    public $targetId;
    protected $_name = [
        'interactInfo' => 'interactInfo',
        'targetId' => 'targetId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->interactInfo) {
            $res['interactInfo'] = $this->interactInfo;
        }
        if (null !== $this->targetId) {
            $res['targetId'] = $this->targetId;
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
        if (isset($map['interactInfo'])) {
            $model->interactInfo = $map['interactInfo'];
        }
        if (isset($map['targetId'])) {
            $model->targetId = $map['targetId'];
        }

        return $model;
    }
}
