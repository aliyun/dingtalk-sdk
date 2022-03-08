<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateBranchVisibleSettingInCooperateRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description 分支的企业ID
     *
     * @var string
     */
    public $branchCorpId;

    /**
     * @description 是否开启 true：开启，false：关闭
     *
     * @var bool
     */
    public $open;

    /**
     * @description 设置可见性类型 0 ：在主干通讯录隐藏分支(其它分支包含主组织都看不到,额外设置可以看到) 1 ： 仅可见分支所在部门(只能看到自己企业加入的成员，额外设置可以看到其它成员)
     *
     * @var int
     */
    public $type;

    /**
     * @description 设置例外的加入合作空间/关联组织的分支企业CorpId列表
     *
     * @var string[]
     */
    public $visibleBranchCorpIds;

    /**
     * @description 设置例外的部门ID列表
     *
     * @var int[]
     */
    public $visibleDeptIds;
    protected $_name = [
        'branchCorpId'         => 'branchCorpId',
        'open'                 => 'open',
        'type'                 => 'type',
        'visibleBranchCorpIds' => 'visibleBranchCorpIds',
        'visibleDeptIds'       => 'visibleDeptIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->branchCorpId) {
            $res['branchCorpId'] = $this->branchCorpId;
        }
        if (null !== $this->open) {
            $res['open'] = $this->open;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->visibleBranchCorpIds) {
            $res['visibleBranchCorpIds'] = $this->visibleBranchCorpIds;
        }
        if (null !== $this->visibleDeptIds) {
            $res['visibleDeptIds'] = $this->visibleDeptIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['branchCorpId'])) {
            $model->branchCorpId = $map['branchCorpId'];
        }
        if (isset($map['open'])) {
            $model->open = $map['open'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['visibleBranchCorpIds'])) {
            if (!empty($map['visibleBranchCorpIds'])) {
                $model->visibleBranchCorpIds = $map['visibleBranchCorpIds'];
            }
        }
        if (isset($map['visibleDeptIds'])) {
            if (!empty($map['visibleDeptIds'])) {
                $model->visibleDeptIds = $map['visibleDeptIds'];
            }
        }

        return $model;
    }
}
