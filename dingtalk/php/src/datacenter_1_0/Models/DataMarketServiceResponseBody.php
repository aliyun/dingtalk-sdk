<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class DataMarketServiceResponseBody extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $data;

    /**
     * @var string
     */
    public $msg;

    /**
     * @var int
     */
    public $totalQuota;

    /**
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'code' => 'code',
        'data' => 'data',
        'msg' => 'msg',
        'totalQuota' => 'totalQuota',
        'usedQuota' => 'usedQuota',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->msg) {
            $res['msg'] = $this->msg;
        }
        if (null !== $this->totalQuota) {
            $res['totalQuota'] = $this->totalQuota;
        }
        if (null !== $this->usedQuota) {
            $res['usedQuota'] = $this->usedQuota;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DataMarketServiceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['msg'])) {
            $model->msg = $map['msg'];
        }
        if (isset($map['totalQuota'])) {
            $model->totalQuota = $map['totalQuota'];
        }
        if (isset($map['usedQuota'])) {
            $model->usedQuota = $map['usedQuota'];
        }

        return $model;
    }
}
