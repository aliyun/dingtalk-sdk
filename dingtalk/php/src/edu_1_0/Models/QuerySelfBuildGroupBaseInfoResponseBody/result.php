<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySelfBuildGroupBaseInfoResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $classId;

    /**
     * @var string
     */
    public $className;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var int
     */
    public $gradeLevel;

    /**
     * @var string
     */
    public $groupType;

    /**
     * @var string
     */
    public $periodCode;

    /**
     * @var string
     */
    public $requestId;
    protected $_name = [
        'classId' => 'classId',
        'className' => 'className',
        'corpId' => 'corpId',
        'gradeLevel' => 'gradeLevel',
        'groupType' => 'groupType',
        'periodCode' => 'periodCode',
        'requestId' => 'requestId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->className) {
            $res['className'] = $this->className;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->gradeLevel) {
            $res['gradeLevel'] = $this->gradeLevel;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->periodCode) {
            $res['periodCode'] = $this->periodCode;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['className'])) {
            $model->className = $map['className'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['gradeLevel'])) {
            $model->gradeLevel = $map['gradeLevel'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['periodCode'])) {
            $model->periodCode = $map['periodCode'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }

        return $model;
    }
}
