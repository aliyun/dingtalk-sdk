<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetUserCardHolderListResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 名片ID
     *
     * @var string
     */
    public $cardId;

    /**
     * @description 名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 头像
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @description 组织名称
     *
     * @var string
     */
    public $orgName;

    /**
     * @description 职位
     *
     * @var string
     */
    public $title;

    /**
     * @description 行业名称
     *
     * @var string
     */
    public $industryName;

    /**
     * @description 个人介绍
     *
     * @var string
     */
    public $introduce;

    /**
     * @description 模板ID
     *
     * @var string
     */
    public $templateId;

    /**
     * @description 扩展信息
     *
     * @var mixed[]
     */
    public $extension;
    protected $_name = [
        'cardId'       => 'cardId',
        'name'         => 'name',
        'avatarUrl'    => 'avatarUrl',
        'orgName'      => 'orgName',
        'title'        => 'title',
        'industryName' => 'industryName',
        'introduce'    => 'introduce',
        'templateId'   => 'templateId',
        'extension'    => 'extension',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->industryName) {
            $res['industryName'] = $this->industryName;
        }
        if (null !== $this->introduce) {
            $res['introduce'] = $this->introduce;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['industryName'])) {
            $model->industryName = $map['industryName'];
        }
        if (isset($map['introduce'])) {
            $model->introduce = $map['introduce'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }

        return $model;
    }
}
