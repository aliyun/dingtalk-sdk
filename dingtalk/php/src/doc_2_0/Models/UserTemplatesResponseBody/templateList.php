<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UserTemplatesResponseBody;

use AlibabaCloud\Tea\Model;

class templateList extends Model
{
    /**
     * @var string
     */
    public $authorName;

    /**
     * @var string
     */
    public $belong;

    /**
     * @var string
     */
    public $contentDownloadUrl;

    /**
     * @var string
     */
    public $coverDownloadUrl;

    /**
     * @var string
     */
    public $createTime;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $modifiedTime;

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
     * @var int
     */
    public $usedCount;

    /**
     * @var string
     */
    public $workspaceId;

    /**
     * @var string
     */
    public $workspaceName;
    protected $_name = [
        'authorName'         => 'authorName',
        'belong'             => 'belong',
        'contentDownloadUrl' => 'contentDownloadUrl',
        'coverDownloadUrl'   => 'coverDownloadUrl',
        'createTime'         => 'createTime',
        'description'        => 'description',
        'modifiedTime'       => 'modifiedTime',
        'templateId'         => 'templateId',
        'title'              => 'title',
        'type'               => 'type',
        'usedCount'          => 'usedCount',
        'workspaceId'        => 'workspaceId',
        'workspaceName'      => 'workspaceName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authorName) {
            $res['authorName'] = $this->authorName;
        }
        if (null !== $this->belong) {
            $res['belong'] = $this->belong;
        }
        if (null !== $this->contentDownloadUrl) {
            $res['contentDownloadUrl'] = $this->contentDownloadUrl;
        }
        if (null !== $this->coverDownloadUrl) {
            $res['coverDownloadUrl'] = $this->coverDownloadUrl;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->usedCount) {
            $res['usedCount'] = $this->usedCount;
        }
        if (null !== $this->workspaceId) {
            $res['workspaceId'] = $this->workspaceId;
        }
        if (null !== $this->workspaceName) {
            $res['workspaceName'] = $this->workspaceName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return templateList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authorName'])) {
            $model->authorName = $map['authorName'];
        }
        if (isset($map['belong'])) {
            $model->belong = $map['belong'];
        }
        if (isset($map['contentDownloadUrl'])) {
            $model->contentDownloadUrl = $map['contentDownloadUrl'];
        }
        if (isset($map['coverDownloadUrl'])) {
            $model->coverDownloadUrl = $map['coverDownloadUrl'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['usedCount'])) {
            $model->usedCount = $map['usedCount'];
        }
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }
        if (isset($map['workspaceName'])) {
            $model->workspaceName = $map['workspaceName'];
        }

        return $model;
    }
}
