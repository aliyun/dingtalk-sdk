<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetDefaultChildResponseBody;

use AlibabaCloud\Tea\Model;

class bindStudents extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $staffId;

    /**
     * @var int
     */
    public $classId;

    /**
     * @var string
     */
    public $period;
    protected $_name = [
        'corpId'  => 'corpId',
        'staffId' => 'staffId',
        'classId' => 'classId',
        'period'  => 'period',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->period) {
            $res['period'] = $this->period;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }

        return $model;
    }
}
