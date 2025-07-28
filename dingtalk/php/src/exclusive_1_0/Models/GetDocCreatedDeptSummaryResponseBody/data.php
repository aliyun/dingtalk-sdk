<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedDeptSummaryResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 100
     *
     * @var string
     */
    public $createDocUserCnt1d;

    /**
     * @example 123
     *
     * @var string
     */
    public $deptId;

    /**
     * @example 部门A
     *
     * @var string
     */
    public $deptName;

    /**
     * @example 100
     *
     * @var string
     */
    public $docCreatedCnt;
    protected $_name = [
        'createDocUserCnt1d' => 'createDocUserCnt1d',
        'deptId' => 'deptId',
        'deptName' => 'deptName',
        'docCreatedCnt' => 'docCreatedCnt',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createDocUserCnt1d) {
            $res['createDocUserCnt1d'] = $this->createDocUserCnt1d;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->docCreatedCnt) {
            $res['docCreatedCnt'] = $this->docCreatedCnt;
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
        if (isset($map['createDocUserCnt1d'])) {
            $model->createDocUserCnt1d = $map['createDocUserCnt1d'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['docCreatedCnt'])) {
            $model->docCreatedCnt = $map['docCreatedCnt'];
        }

        return $model;
    }
}
