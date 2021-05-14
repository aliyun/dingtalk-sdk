<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetWebChannelUserTokenRequest extends Model
{
    /**
     * @description 调用方在小蜜客服平台申请的业务账号体系的id
     *
     * @var int
     */
    public $source;

    /**
     * @description 登录用户在业务账号体系内的昵称
     *
     * @var string
     */
    public $nick;

    /**
     * @description 企业corpId
     *
     * @var string
     */
    public $dingCorpId;

    /**
     * @description 登录用户在业务账号体系内的用户id
     *
     * @var string
     */
    public $foreignId;
    protected $_name = [
        'source'     => 'source',
        'nick'       => 'nick',
        'dingCorpId' => 'dingCorpId',
        'foreignId'  => 'foreignId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->foreignId) {
            $res['foreignId'] = $this->foreignId;
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
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['foreignId'])) {
            $model->foreignId = $map['foreignId'];
        }

        return $model;
    }
}
