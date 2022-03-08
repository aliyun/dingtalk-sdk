<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAllLabelableDeptsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAllLabelableDeptsResponseBody\data\partnerLabelVOLevel1;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAllLabelableDeptsResponseBody\data\partnerLabelVOLevel2;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAllLabelableDeptsResponseBody\data\partnerLabelVOLevel3;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAllLabelableDeptsResponseBody\data\partnerLabelVOLevel4;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAllLabelableDeptsResponseBody\data\partnerLabelVOLevel5;
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
     * @description 部门人数
     *
     * @var int
     */
    public $memberCount;

    /**
     * @description 部门一级伙伴类型
     *
     * @var partnerLabelVOLevel1
     */
    public $partnerLabelVOLevel1;

    /**
     * @description 部门二级伙伴类型
     *
     * @var partnerLabelVOLevel2
     */
    public $partnerLabelVOLevel2;

    /**
     * @description 部门三级伙伴类型
     *
     * @var partnerLabelVOLevel3
     */
    public $partnerLabelVOLevel3;

    /**
     * @description 部门四级伙伴类型
     *
     * @var partnerLabelVOLevel4
     */
    public $partnerLabelVOLevel4;

    /**
     * @description 部门五级伙伴类型
     *
     * @var partnerLabelVOLevel5
     */
    public $partnerLabelVOLevel5;

    /**
     * @description 部门伙伴编码
     *
     * @var string
     */
    public $partnerNum;

    /**
     * @description 父部门id
     *
     * @var string
     */
    public $superDeptId;
    protected $_name = [
        'deptId'               => 'deptId',
        'deptName'             => 'deptName',
        'memberCount'          => 'memberCount',
        'partnerLabelVOLevel1' => 'partnerLabelVOLevel1',
        'partnerLabelVOLevel2' => 'partnerLabelVOLevel2',
        'partnerLabelVOLevel3' => 'partnerLabelVOLevel3',
        'partnerLabelVOLevel4' => 'partnerLabelVOLevel4',
        'partnerLabelVOLevel5' => 'partnerLabelVOLevel5',
        'partnerNum'           => 'partnerNum',
        'superDeptId'          => 'superDeptId',
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
        if (null !== $this->memberCount) {
            $res['memberCount'] = $this->memberCount;
        }
        if (null !== $this->partnerLabelVOLevel1) {
            $res['partnerLabelVOLevel1'] = null !== $this->partnerLabelVOLevel1 ? $this->partnerLabelVOLevel1->toMap() : null;
        }
        if (null !== $this->partnerLabelVOLevel2) {
            $res['partnerLabelVOLevel2'] = null !== $this->partnerLabelVOLevel2 ? $this->partnerLabelVOLevel2->toMap() : null;
        }
        if (null !== $this->partnerLabelVOLevel3) {
            $res['partnerLabelVOLevel3'] = null !== $this->partnerLabelVOLevel3 ? $this->partnerLabelVOLevel3->toMap() : null;
        }
        if (null !== $this->partnerLabelVOLevel4) {
            $res['partnerLabelVOLevel4'] = null !== $this->partnerLabelVOLevel4 ? $this->partnerLabelVOLevel4->toMap() : null;
        }
        if (null !== $this->partnerLabelVOLevel5) {
            $res['partnerLabelVOLevel5'] = null !== $this->partnerLabelVOLevel5 ? $this->partnerLabelVOLevel5->toMap() : null;
        }
        if (null !== $this->partnerNum) {
            $res['partnerNum'] = $this->partnerNum;
        }
        if (null !== $this->superDeptId) {
            $res['superDeptId'] = $this->superDeptId;
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
        if (isset($map['memberCount'])) {
            $model->memberCount = $map['memberCount'];
        }
        if (isset($map['partnerLabelVOLevel1'])) {
            $model->partnerLabelVOLevel1 = partnerLabelVOLevel1::fromMap($map['partnerLabelVOLevel1']);
        }
        if (isset($map['partnerLabelVOLevel2'])) {
            $model->partnerLabelVOLevel2 = partnerLabelVOLevel2::fromMap($map['partnerLabelVOLevel2']);
        }
        if (isset($map['partnerLabelVOLevel3'])) {
            $model->partnerLabelVOLevel3 = partnerLabelVOLevel3::fromMap($map['partnerLabelVOLevel3']);
        }
        if (isset($map['partnerLabelVOLevel4'])) {
            $model->partnerLabelVOLevel4 = partnerLabelVOLevel4::fromMap($map['partnerLabelVOLevel4']);
        }
        if (isset($map['partnerLabelVOLevel5'])) {
            $model->partnerLabelVOLevel5 = partnerLabelVOLevel5::fromMap($map['partnerLabelVOLevel5']);
        }
        if (isset($map['partnerNum'])) {
            $model->partnerNum = $map['partnerNum'];
        }
        if (isset($map['superDeptId'])) {
            $model->superDeptId = $map['superDeptId'];
        }

        return $model;
    }
}
