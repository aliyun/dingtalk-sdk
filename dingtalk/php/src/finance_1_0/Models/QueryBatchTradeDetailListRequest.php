<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBatchTradeDetailListRequest extends Model
{
    /**
     * @description isv corpId
     *
     * @var string
     */
    public $isvCorpId;

    /**
     * @description 外部商户批次号
     *
     * @var string
     */
    public $outBatchNo;

    /**
     * @description 当前页数
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 每页记录数
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description ISV/企业自建应用suiteId
     *
     * @var string
     */
    public $suiteId;
    protected $_name = [
        'isvCorpId'  => 'isvCorpId',
        'outBatchNo' => 'outBatchNo',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'suiteId'    => 'suiteId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isvCorpId) {
            $res['isvCorpId'] = $this->isvCorpId;
        }
        if (null !== $this->outBatchNo) {
            $res['outBatchNo'] = $this->outBatchNo;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->suiteId) {
            $res['suiteId'] = $this->suiteId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBatchTradeDetailListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isvCorpId'])) {
            $model->isvCorpId = $map['isvCorpId'];
        }
        if (isset($map['outBatchNo'])) {
            $model->outBatchNo = $map['outBatchNo'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['suiteId'])) {
            $model->suiteId = $map['suiteId'];
        }

        return $model;
    }
}
