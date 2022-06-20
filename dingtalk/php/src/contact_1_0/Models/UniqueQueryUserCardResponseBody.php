<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UniqueQueryUserCardResponseBody extends Model
{
    /**
     * @description 图标
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @description 名片id
     *
     * @var string
     */
    public $cardId;

    /**
     * @description 额外信息
     *
     * @var mixed[]
     */
    public $extension;

    /**
     * @description 工业名
     *
     * @var string
     */
    public $industryName;

    /**
     * @description 介绍
     *
     * @var string
     */
    public $introduce;

    /**
     * @description 名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 组织名
     *
     * @var string
     */
    public $orgName;

    /**
     * @description 模版id
     *
     * @var string
     */
    public $templateId;

    /**
     * @description 标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'avatarUrl'    => 'avatarUrl',
        'cardId'       => 'cardId',
        'extension'    => 'extension',
        'industryName' => 'industryName',
        'introduce'    => 'introduce',
        'name'         => 'name',
        'orgName'      => 'orgName',
        'templateId'   => 'templateId',
        'title'        => 'title',
    ];

    public function validate()
    {
    }

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
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
