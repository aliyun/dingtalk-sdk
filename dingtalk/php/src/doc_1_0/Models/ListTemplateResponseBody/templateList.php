<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ListTemplateResponseBody;

use AlibabaCloud\Tea\Model;

class templateList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $docType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $templateType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $title;

    /**
     * @var int
     */
    public $updateTime;

    /**
     * @var string
     */
    public $workspaceId;
    protected $_name = [
        'coverUrl'     => 'coverUrl',
        'createTime'   => 'createTime',
        'docType'      => 'docType',
        'id'           => 'id',
        'templateType' => 'templateType',
        'title'        => 'title',
        'updateTime'   => 'updateTime',
        'workspaceId'  => 'workspaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->coverUrl) {
            $res['coverUrl'] = $this->coverUrl;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->docType) {
            $res['docType'] = $this->docType;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->templateType) {
            $res['templateType'] = $this->templateType;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }
        if (null !== $this->workspaceId) {
            $res['workspaceId'] = $this->workspaceId;
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
        if (isset($map['coverUrl'])) {
            $model->coverUrl = $map['coverUrl'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['docType'])) {
            $model->docType = $map['docType'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['templateType'])) {
            $model->templateType = $map['templateType'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }

        return $model;
    }
}
