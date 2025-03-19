<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCollectionInfoListResponseBody;

use AlibabaCloud\Tea\Model;

class collectionInfoList extends Model
{
    /**
     * @var string
     */
    public $accountHolderName;

    /**
     * @var string
     */
    public $alipayLogonId;

    /**
     * @var string
     */
    public $auditStatus;

    /**
     * @var string
     */
    public $certNo;

    /**
     * @var string
     */
    public $collectionInfoId;

    /**
     * @var string
     */
    public $failReason;

    /**
     * @var int
     */
    public $gmtAudit;

    /**
     * @var string
     */
    public $merchantName;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'accountHolderName' => 'accountHolderName',
        'alipayLogonId' => 'alipayLogonId',
        'auditStatus' => 'auditStatus',
        'certNo' => 'certNo',
        'collectionInfoId' => 'collectionInfoId',
        'failReason' => 'failReason',
        'gmtAudit' => 'gmtAudit',
        'merchantName' => 'merchantName',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountHolderName) {
            $res['accountHolderName'] = $this->accountHolderName;
        }
        if (null !== $this->alipayLogonId) {
            $res['alipayLogonId'] = $this->alipayLogonId;
        }
        if (null !== $this->auditStatus) {
            $res['auditStatus'] = $this->auditStatus;
        }
        if (null !== $this->certNo) {
            $res['certNo'] = $this->certNo;
        }
        if (null !== $this->collectionInfoId) {
            $res['collectionInfoId'] = $this->collectionInfoId;
        }
        if (null !== $this->failReason) {
            $res['failReason'] = $this->failReason;
        }
        if (null !== $this->gmtAudit) {
            $res['gmtAudit'] = $this->gmtAudit;
        }
        if (null !== $this->merchantName) {
            $res['merchantName'] = $this->merchantName;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return collectionInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountHolderName'])) {
            $model->accountHolderName = $map['accountHolderName'];
        }
        if (isset($map['alipayLogonId'])) {
            $model->alipayLogonId = $map['alipayLogonId'];
        }
        if (isset($map['auditStatus'])) {
            $model->auditStatus = $map['auditStatus'];
        }
        if (isset($map['certNo'])) {
            $model->certNo = $map['certNo'];
        }
        if (isset($map['collectionInfoId'])) {
            $model->collectionInfoId = $map['collectionInfoId'];
        }
        if (isset($map['failReason'])) {
            $model->failReason = $map['failReason'];
        }
        if (isset($map['gmtAudit'])) {
            $model->gmtAudit = $map['gmtAudit'];
        }
        if (isset($map['merchantName'])) {
            $model->merchantName = $map['merchantName'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
