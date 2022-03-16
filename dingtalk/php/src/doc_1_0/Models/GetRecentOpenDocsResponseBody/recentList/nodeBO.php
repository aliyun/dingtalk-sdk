<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentOpenDocsResponseBody\recentList;

use AlibabaCloud\Tea\Model;

class nodeBO extends Model
{
    /**
     * @description 创建时间
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 节点类型
     *
     * @var string
     */
    public $docType;

    /**
     * @description 是否被删除
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @description 最后编辑时间
     *
     * @var int
     */
    public $lastOpenTime;

    /**
     * @description 文档Id
     *
     * @var string
     */
    public $nodeId;

    /**
     * @description 文档名称
     *
     * @var string
     */
    public $nodeName;

    /**
     * @description 文档更新时间，包括重命名、移动、内容编辑等操作都会刷新更新时间
     *
     * @var int
     */
    public $updateTime;

    /**
     * @description 文档打开url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'createTime'   => 'createTime',
        'docType'      => 'docType',
        'isDeleted'    => 'isDeleted',
        'lastOpenTime' => 'lastOpenTime',
        'nodeId'       => 'nodeId',
        'nodeName'     => 'nodeName',
        'updateTime'   => 'updateTime',
        'url'          => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->docType) {
            $res['docType'] = $this->docType;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->lastOpenTime) {
            $res['lastOpenTime'] = $this->lastOpenTime;
        }
        if (null !== $this->nodeId) {
            $res['nodeId'] = $this->nodeId;
        }
        if (null !== $this->nodeName) {
            $res['nodeName'] = $this->nodeName;
        }
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return nodeBO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['docType'])) {
            $model->docType = $map['docType'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['lastOpenTime'])) {
            $model->lastOpenTime = $map['lastOpenTime'];
        }
        if (isset($map['nodeId'])) {
            $model->nodeId = $map['nodeId'];
        }
        if (isset($map['nodeName'])) {
            $model->nodeName = $map['nodeName'];
        }
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
