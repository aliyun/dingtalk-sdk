<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetDefaultChildResponseBody;

use AlibabaCloud\Tea\Model;

class bindStudents extends Model
{
    /**
     * @var int
     */
    public $classId;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $period;

    /**
     * @var string
     */
    public $staffId;
    protected $_name = [
        'classId' => 'classId',
        'corpId'  => 'corpId',
        'period'  => 'period',
        'staffId' => 'staffId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->period) {
            $res['period'] = $this->period;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return bindStudents
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}
