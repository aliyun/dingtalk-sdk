<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryPaymentRecallFileRequest extends Model
{
    /**
     * @var string[]
     */
    public $detailIdList;

    /**
     * @var string
     */
    public $opeator;
    protected $_name = [
        'detailIdList' => 'detailIdList',
        'opeator'      => 'opeator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->detailIdList) {
            $res['detailIdList'] = $this->detailIdList;
        }
        if (null !== $this->opeator) {
            $res['opeator'] = $this->opeator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryPaymentRecallFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['detailIdList'])) {
            if (!empty($map['detailIdList'])) {
                $model->detailIdList = $map['detailIdList'];
            }
        }
        if (isset($map['opeator'])) {
            $model->opeator = $map['opeator'];
        }

        return $model;
    }
}
