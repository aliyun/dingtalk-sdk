<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CardTemplateBuildActionRequest extends Model
{
    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingOauthAppId;

    /**
     * @description 模板构建的action：含create、save、deploy
     *
     * @var string
     */
    public $action;

    /**
     * @description 模板构建的dto对象
     *
     * @var string
     */
    public $cardTemplateJson;
    protected $_name = [
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingOrgId'          => 'dingOrgId',
        'dingOauthAppId'     => 'dingOauthAppId',
        'action'             => 'action',
        'cardTemplateJson'   => 'cardTemplateJson',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingOauthAppId) {
            $res['dingOauthAppId'] = $this->dingOauthAppId;
        }
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->cardTemplateJson) {
            $res['cardTemplateJson'] = $this->cardTemplateJson;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CardTemplateBuildActionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingOauthAppId'])) {
            $model->dingOauthAppId = $map['dingOauthAppId'];
        }
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['cardTemplateJson'])) {
            $model->cardTemplateJson = $map['cardTemplateJson'];
        }

        return $model;
    }
}
