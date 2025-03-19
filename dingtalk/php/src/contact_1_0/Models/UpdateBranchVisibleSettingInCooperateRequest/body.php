<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateBranchVisibleSettingInCooperateRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ding1234
     *
     * @var string
     */
    public $branchCorpId;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $open;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $type;

    /**
     * @var string[]
     */
    public $visibleBranchCorpIds;

    /**
     * @var int[]
     */
    public $visibleDeptIds;
    protected $_name = [
        'branchCorpId' => 'branchCorpId',
        'open' => 'open',
        'type' => 'type',
        'visibleBranchCorpIds' => 'visibleBranchCorpIds',
        'visibleDeptIds' => 'visibleDeptIds',
    ];

    public function validate() {}

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
