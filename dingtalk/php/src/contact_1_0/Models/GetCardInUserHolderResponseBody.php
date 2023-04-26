<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCardInUserHolderResponseBody extends Model
{
    /**
     * @var string
     */
    public $avatarUrl;

    /**
     * @var int
     */
    public $cardAcceptStatus;

    /**
     * @var int
     */
    public $cardAcceptTimeLong;

    /**
     * @var string
     */
    public $cardId;

    /**
     * @example 0
     *
     * @var int
     */
    public $cardSource;

    /**
     * @var mixed[]
     */
    public $extension;

    /**
     * @var string
     */
    public $industryName;

    /**
     * @var string
     */
    public $introduce;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $orgName;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'avatarUrl'          => 'avatarUrl',
        'cardAcceptStatus'   => 'cardAcceptStatus',
        'cardAcceptTimeLong' => 'cardAcceptTimeLong',
        'cardId'             => 'cardId',
        'cardSource'         => 'cardSource',
        'extension'          => 'extension',
        'industryName'       => 'industryName',
        'introduce'          => 'introduce',
        'name'               => 'name',
        'orgName'            => 'orgName',
        'templateId'         => 'templateId',
        'title'              => 'title',
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
        if (null !== $this->cardAcceptStatus) {
            $res['cardAcceptStatus'] = $this->cardAcceptStatus;
        }
        if (null !== $this->cardAcceptTimeLong) {
            $res['cardAcceptTimeLong'] = $this->cardAcceptTimeLong;
        }
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
        }
        if (null !== $this->cardSource) {
            $res['cardSource'] = $this->cardSource;
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
     * @return GetCardInUserHolderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['cardAcceptStatus'])) {
            $model->cardAcceptStatus = $map['cardAcceptStatus'];
        }
        if (isset($map['cardAcceptTimeLong'])) {
            $model->cardAcceptTimeLong = $map['cardAcceptTimeLong'];
        }
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
        }
        if (isset($map['cardSource'])) {
            $model->cardSource = $map['cardSource'];
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
