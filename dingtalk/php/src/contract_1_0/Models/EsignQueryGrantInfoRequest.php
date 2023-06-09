<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class EsignQueryGrantInfoRequest extends Model
{
    /**
     * @example dingd0c871e2dfc941a34ac5d6980864d335
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string[]
     */
    public $extension;

    /**
     * @example PbnhW6rVXRg8u6T4NiiOwwQiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'corpId'    => 'corpId',
        'extension' => 'extension',
        'unionId'   => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EsignQueryGrantInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
