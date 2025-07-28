<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncInvoiceEntityRequest\entityList;
use AlibabaCloud\Tea\Model;

class SyncInvoiceEntityRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ding89233847892ndkas
     *
     * @var string
     */
    public $channelCorpId;

    /**
     * @var bool
     */
    public $delAll;

    /**
     * @var entityList[]
     */
    public $entityList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $invoiceId;

    /**
     * @description This parameter is required.
     *
     * @example 20881001829000
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'channelCorpId' => 'channelCorpId',
        'delAll' => 'delAll',
        'entityList' => 'entityList',
        'invoiceId' => 'invoiceId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->channelCorpId) {
            $res['channelCorpId'] = $this->channelCorpId;
        }
        if (null !== $this->delAll) {
            $res['delAll'] = $this->delAll;
        }
        if (null !== $this->entityList) {
            $res['entityList'] = [];
            if (null !== $this->entityList && \is_array($this->entityList)) {
                $n = 0;
                foreach ($this->entityList as $item) {
                    $res['entityList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->invoiceId) {
            $res['invoiceId'] = $this->invoiceId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncInvoiceEntityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channelCorpId'])) {
            $model->channelCorpId = $map['channelCorpId'];
        }
        if (isset($map['delAll'])) {
            $model->delAll = $map['delAll'];
        }
        if (isset($map['entityList'])) {
            if (!empty($map['entityList'])) {
                $model->entityList = [];
                $n = 0;
                foreach ($map['entityList'] as $item) {
                    $model->entityList[$n++] = null !== $item ? entityList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['invoiceId'])) {
            $model->invoiceId = $map['invoiceId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
