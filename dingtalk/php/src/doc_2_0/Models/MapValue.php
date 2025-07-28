<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class MapValue extends Model
{
    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $title;

    /**
     * @var int
     */
    public $type;

    /**
     * @var string
     */
    public $coverDownloadUrl;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $authorName;

    /**
     * @var string
     */
    public $createTime;

    /**
     * @var string
     */
    public $modifiedTime;

    /**
     * @var string
     */
    public $workspaceId;

    /**
     * @var string
     */
    public $workspaceName;

    /**
     * @var int
     */
    public $usedCount;

    /**
     * @var string
     */
    public $belong;

    /**
     * @var string
     */
    public $contentDownloadUrl;
    protected $_name = [
        'templateId' => 'templateId',
        'title' => 'title',
        'type' => 'type',
        'coverDownloadUrl' => 'coverDownloadUrl',
        'description' => 'description',
        'authorName' => 'authorName',
        'createTime' => 'createTime',
        'modifiedTime' => 'modifiedTime',
        'workspaceId' => 'workspaceId',
        'workspaceName' => 'workspaceName',
        'usedCount' => 'usedCount',
        'belong' => 'belong',
        'contentDownloadUrl' => 'contentDownloadUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->coverDownloadUrl) {
            $res['coverDownloadUrl'] = $this->coverDownloadUrl;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->authorName) {
            $res['authorName'] = $this->authorName;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->workspaceId) {
            $res['workspaceId'] = $this->workspaceId;
        }
        if (null !== $this->workspaceName) {
            $res['workspaceName'] = $this->workspaceName;
        }
        if (null !== $this->usedCount) {
            $res['usedCount'] = $this->usedCount;
        }
        if (null !== $this->belong) {
            $res['belong'] = $this->belong;
        }
        if (null !== $this->contentDownloadUrl) {
            $res['contentDownloadUrl'] = $this->contentDownloadUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MapValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['coverDownloadUrl'])) {
            $model->coverDownloadUrl = $map['coverDownloadUrl'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['authorName'])) {
            $model->authorName = $map['authorName'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }
        if (isset($map['workspaceName'])) {
            $model->workspaceName = $map['workspaceName'];
        }
        if (isset($map['usedCount'])) {
            $model->usedCount = $map['usedCount'];
        }
        if (isset($map['belong'])) {
            $model->belong = $map['belong'];
        }
        if (isset($map['contentDownloadUrl'])) {
            $model->contentDownloadUrl = $map['contentDownloadUrl'];
        }

        return $model;
    }
}
