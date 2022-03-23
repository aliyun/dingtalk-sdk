<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDocCreatedDeptSummaryResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 最近1天创建文档人数
     *
     * @var string
     */
    public $createDocUserCnt1d;

    /**
     * @description 部门id
     *
     * @var string
     */
    public $deptId;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $deptName;

    /**
     * @description 最近1天钉钉文档创建数
     *
     * @var string
     */
    public $docCreatedCnt;
    protected $_name = [
        'createDocUserCnt1d' => 'createDocUserCnt1d',
        'deptId'             => 'deptId',
        'deptName'           => 'deptName',
        'docCreatedCnt'      => 'docCreatedCnt',
    ];

    public function validate()
    {
    }

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
