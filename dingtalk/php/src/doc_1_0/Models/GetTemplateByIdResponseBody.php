<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTemplateByIdResponseBody extends Model
{
    /**
     * @description 模版预览url
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @description 模版创建时间
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 模版对应文档类型
     *
     * @var string
     */
    public $docType;

    /**
     * @description 模版id
     *
     * @var string
     */
    public $id;

    /**
     * @description 模版类型
     *
     * @var string
     */
    public $templateType;

    /**
     * @description 模版标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 模版修改时间
     *
     * @var int
     */
    public $updateTime;

    /**
     * @description 模版归属知识库id。
     *
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
     * @return GetTemplateByIdResponseBody
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
