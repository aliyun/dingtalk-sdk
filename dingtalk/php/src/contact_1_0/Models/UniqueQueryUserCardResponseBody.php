<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UniqueQueryUserCardResponseBody extends Model
{
    /**
     * @example @lADPD2sQxoYs677NAavNAao
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @example CARD-6F0DA174-A0F4-4EBF-B24B-5FDFA648D25E
     *
     * @var string
     */
    public $cardId;

    /**
     * @var mixed[]
     */
    public $extension;

    /**
     * @example 工业
     *
     * @var string
     */
    public $industryName;

    /**
     * @example 我是谁
     *
     * @var string
     */
    public $introduce;

    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example 测试企业
     *
     * @var string
     */
    public $orgName;

    /**
     * @var mixed[]
     */
    public $settings;

    /**
     * @example 163520027_5FE66C522EA142C8r7Abf7VY
     *
     * @var string
     */
    public $templateId;

    /**
     * @example 标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'avatarUrl' => 'avatarUrl',
        'cardId' => 'cardId',
        'extension' => 'extension',
        'industryName' => 'industryName',
        'introduce' => 'introduce',
        'name' => 'name',
        'orgName' => 'orgName',
        'settings' => 'settings',
        'templateId' => 'templateId',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->industryName) {
            $res['industryName'] = $this->industryName;
        }
        if (null !== $this->introduce) {
            $res['introduce'] = $this->introduce;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->settings) {
            $res['settings'] = $this->settings;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UniqueQueryUserCardResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['industryName'])) {
            $model->industryName = $map['industryName'];
        }
        if (isset($map['introduce'])) {
            $model->introduce = $map['introduce'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['settings'])) {
            $model->settings = $map['settings'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
