<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOrgPointDetailsRequest extends Model
{
    /**
     * @description 查询企业账号明细，ORG,ORG_DEDUCTIONS两种。     ORG:企业账户明细 查询的是企业积分发放明细       ORG_DEDUCTIONS:扣除账户明细，查询的是企业扣减积分明细
     *
     * @var string
     */
    public $accountType;

    /**
     * @description 查询页数 第一页是1 非空必传
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 每页大小最多50，默认10
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 操作人userId 必须是管理员
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'accountType' => 'accountType',
        'pageNumber'  => 'pageNumber',
        'pageSize'    => 'pageSize',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountType) {
            $res['accountType'] = $this->accountType;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrgPointDetailsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountType'])) {
            $model->accountType = $map['accountType'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
