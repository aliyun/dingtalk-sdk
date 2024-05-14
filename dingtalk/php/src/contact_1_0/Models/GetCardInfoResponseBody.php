<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension;
use AlibabaCloud\Tea\Model;

class GetCardInfoResponseBody extends Model
{
    /**
     * @var int
     */
    public $adminRole;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $cardId;

    /**
     * @var extension
     */
    public $extension;

    /**
     * @var string
     */
    public $industryName;

    /**
     * @var mixed[]
     */
    public $introduce;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $orgName;

    /**
     * @var mixed[]
     */
    public $settings;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'adminRole'    => 'adminRole',
        'avatarUrl'    => 'avatarUrl',
        'cardId'       => 'cardId',
        'extension'    => 'extension',
        'industryName' => 'industryName',
        'introduce'    => 'introduce',
        'name'         => 'name',
        'orgName'      => 'orgName',
        'settings'     => 'settings',
        'templateId'   => 'templateId',
        'title'        => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->adminRole) {
            $res['adminRole'] = $this->adminRole;
        }
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
        }
        if (null !== $this->extension) {
            $res['extension'] = null !== $this->extension ? $this->extension->toMap() : null;
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
     * @return GetCardInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adminRole'])) {
            $model->adminRole = $map['adminRole'];
        }
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
        }
        if (isset($map['extension'])) {
            $model->extension = extension::fromMap($map['extension']);
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
