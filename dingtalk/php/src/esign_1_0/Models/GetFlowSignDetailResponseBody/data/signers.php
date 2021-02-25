<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetFlowSignDetailResponseBody\data;

use AlibabaCloud\Tea\Model;

class signers extends Model
{
    /**
     * @var string
     */
    public $signerName;

    /**
     * @var int
     */
    public $signStatus;
    protected $_name = [
        'signerName' => 'signerName',
        'signStatus' => 'signStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->signerName) {
            $res['signerName'] = $this->signerName;
        }
        if (null !== $this->signStatus) {
            $res['signStatus'] = $this->signStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['signerName'])) {
            $model->signerName = $map['signerName'];
        }
        if (isset($map['signStatus'])) {
            $model->signStatus = $map['signStatus'];
        }

        return $model;
    }
}
