<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody;

use AlibabaCloud\Tea\Model;

class interactiveMessage extends Model
{
    /**
     * @description 需要回调的互动卡片可通过此参数定义回调地址
     *
     * @var string
     */
    public $callbackUrl;

    /**
     * @description 卡片ID，由开发者自定义，同一卡片此ID需要保持一致。
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @description 互动卡片数据，必须是json object 格式
     *
     * @var string
     */
    public $cardData;

    /**
     * @description 卡片模板ID，可通过互动卡片搭建后台获取。
     *
     * @var string
     */
    public $cardTemplateId;
    protected $_name = [
        'callbackUrl'    => 'callbackUrl',
        'cardBizId'      => 'cardBizId',
        'cardData'       => 'cardData',
        'cardTemplateId' => 'cardTemplateId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->callbackUrl) {
            $res['callbackUrl'] = $this->callbackUrl;
        }
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = $this->cardData;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return interactiveMessage
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callbackUrl'])) {
            $model->callbackUrl = $map['callbackUrl'];
        }
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['cardData'])) {
            $model->cardData = $map['cardData'];
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }

        return $model;
    }
}
