<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\GetSignDetailResponseBody\signers;
use AlibabaCloud\Tea\Model;

class GetSignDetailResponseBody extends Model
{
    /**
     * @var string
     */
    public $businessScene;

    /**
     * @var float
     */
    public $flowStatus;

    /**
     * @var signers[]
     */
    public $signers;
    protected $_name = [
        'businessScene' => 'businessScene',
        'flowStatus'    => 'flowStatus',
        'signers'       => 'signers',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->businessScene) {
            $res['businessScene'] = $this->businessScene;
        }
        if (null !== $this->flowStatus) {
            $res['flowStatus'] = $this->flowStatus;
        }
        if (null !== $this->signers) {
            $res['signers'] = [];
            if (null !== $this->signers && \is_array($this->signers)) {
                $n = 0;
                foreach ($this->signers as $item) {
                    $res['signers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSignDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['businessScene'])) {
            $model->businessScene = $map['businessScene'];
        }
        if (isset($map['flowStatus'])) {
            $model->flowStatus = $map['flowStatus'];
        }
        if (isset($map['signers'])) {
            if (!empty($map['signers'])) {
                $model->signers = [];
                $n              = 0;
                foreach ($map['signers'] as $item) {
                    $model->signers[$n++] = null !== $item ? signers::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
