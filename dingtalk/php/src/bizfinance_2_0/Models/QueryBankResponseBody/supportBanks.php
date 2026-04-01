<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryBankResponseBody;

use AlibabaCloud\Tea\Model;

class supportBanks extends Model
{
    /**
     * @var string
     */
    public $bankAbbr;

    /**
     * @var string
     */
    public $bankFirstPinYin;

    /**
     * @var string
     */
    public $bankName;
    protected $_name = [
        'bankAbbr' => 'bankAbbr',
        'bankFirstPinYin' => 'bankFirstPinYin',
        'bankName' => 'bankName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bankAbbr) {
            $res['bankAbbr'] = $this->bankAbbr;
        }
        if (null !== $this->bankFirstPinYin) {
            $res['bankFirstPinYin'] = $this->bankFirstPinYin;
        }
        if (null !== $this->bankName) {
            $res['bankName'] = $this->bankName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return supportBanks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bankAbbr'])) {
            $model->bankAbbr = $map['bankAbbr'];
        }
        if (isset($map['bankFirstPinYin'])) {
            $model->bankFirstPinYin = $map['bankFirstPinYin'];
        }
        if (isset($map['bankName'])) {
            $model->bankName = $map['bankName'];
        }

        return $model;
    }
}
