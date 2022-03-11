<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class BanOrOpenGroupWordsRequest extends Model
{
    /**
     * @description 操作类型:0 不禁言;1:禁言
     *
     * @var int
     */
    public $banWordsType;

    /**
     * @description 群id
     *
     * @var string
     */
    public $openConverationId;
    protected $_name = [
        'banWordsType'      => 'banWordsType',
        'openConverationId' => 'openConverationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->banWordsType) {
            $res['banWordsType'] = $this->banWordsType;
        }
        if (null !== $this->openConverationId) {
            $res['openConverationId'] = $this->openConverationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BanOrOpenGroupWordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['banWordsType'])) {
            $model->banWordsType = $map['banWordsType'];
        }
        if (isset($map['openConverationId'])) {
            $model->openConverationId = $map['openConverationId'];
        }

        return $model;
    }
}
