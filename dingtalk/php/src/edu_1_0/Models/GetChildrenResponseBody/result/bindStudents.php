<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetChildrenResponseBody\result;

use AlibabaCloud\Tea\Model;

class bindStudents extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $gradeLevel;

    /**
     * @example dinge066bea21c63b79b35c2f4657eb6378f
     *
     * @var string
     */
    public $identityId;

    /**
     * @example primary_school
     *
     * @var string
     */
    public $periodCode;
    protected $_name = [
        'gradeLevel' => 'gradeLevel',
        'identityId' => 'identityId',
        'periodCode' => 'periodCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->gradeLevel) {
            $res['gradeLevel'] = $this->gradeLevel;
        }
        if (null !== $this->identityId) {
            $res['identityId'] = $this->identityId;
        }
        if (null !== $this->periodCode) {
            $res['periodCode'] = $this->periodCode;
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
        if (isset($map['gradeLevel'])) {
            $model->gradeLevel = $map['gradeLevel'];
        }
        if (isset($map['identityId'])) {
            $model->identityId = $map['identityId'];
        }
        if (isset($map['periodCode'])) {
            $model->periodCode = $map['periodCode'];
        }

        return $model;
    }
}
