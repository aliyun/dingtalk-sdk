<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGeneralFormCreatedDeptSummaryResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
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
     * @description 最近1天累计发布智能填表数
     *
     * @var string
     */
    public $generalFormCreateCnt1d;

    /**
     * @description 最近1天使用智能填表人数
     *
     * @var string
     */
    public $useGeneralFormUserCnt1d;
    protected $_name = [
        'deptId'                  => 'deptId',
        'deptName'                => 'deptName',
        'generalFormCreateCnt1d'  => 'generalFormCreateCnt1d',
        'useGeneralFormUserCnt1d' => 'useGeneralFormUserCnt1d',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->generalFormCreateCnt1d) {
            $res['generalFormCreateCnt1d'] = $this->generalFormCreateCnt1d;
        }
        if (null !== $this->useGeneralFormUserCnt1d) {
            $res['useGeneralFormUserCnt1d'] = $this->useGeneralFormUserCnt1d;
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
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['generalFormCreateCnt1d'])) {
            $model->generalFormCreateCnt1d = $map['generalFormCreateCnt1d'];
        }
        if (isset($map['useGeneralFormUserCnt1d'])) {
            $model->useGeneralFormUserCnt1d = $map['useGeneralFormUserCnt1d'];
        }

        return $model;
    }
}
