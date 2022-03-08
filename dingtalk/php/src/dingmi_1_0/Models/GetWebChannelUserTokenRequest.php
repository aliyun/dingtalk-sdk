<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetWebChannelUserTokenRequest extends Model
{
    /**
     * @description 登录用户在业务账号体系内的用户id
     *
     * @var string
     */
    public $foreignId;

    /**
     * @description 登录用户在业务账号体系内的昵称
     *
     * @var string
     */
    public $nick;

    /**
     * @description 调用方在小蜜客服平台申请的业务账号体系的id
     *
     * @var int
     */
    public $source;
    protected $_name = [
        'foreignId' => 'foreignId',
        'nick'      => 'nick',
        'source'    => 'source',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->foreignId) {
            $res['foreignId'] = $this->foreignId;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetWebChannelUserTokenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['foreignId'])) {
            $model->foreignId = $map['foreignId'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }

        return $model;
    }
}
