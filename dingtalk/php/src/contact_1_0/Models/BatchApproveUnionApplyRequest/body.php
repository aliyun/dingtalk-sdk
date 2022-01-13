<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\BatchApproveUnionApplyRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description branchCorpId
     *
     * @var string
     */
    public $branchCorpId;

    /**
     * @description unionRootName
     *
     * @var string
     */
    public $unionRootName;

    /**
     * @description linkDeptId
     *
     * @var int
     */
    public $linkDeptId;
    protected $_name = [
        'branchCorpId'  => 'branchCorpId',
        'unionRootName' => 'unionRootName',
        'linkDeptId'    => 'linkDeptId',
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
        if (null !== $this->unionRootName) {
            $res['unionRootName'] = $this->unionRootName;
        }
        if (null !== $this->linkDeptId) {
            $res['linkDeptId'] = $this->linkDeptId;
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
        if (isset($map['unionRootName'])) {
            $model->unionRootName = $map['unionRootName'];
        }
        if (isset($map['linkDeptId'])) {
            $model->linkDeptId = $map['linkDeptId'];
        }

        return $model;
    }
}
