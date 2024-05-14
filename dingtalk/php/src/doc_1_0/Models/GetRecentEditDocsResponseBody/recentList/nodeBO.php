<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsResponseBody\recentList;

use AlibabaCloud\Tea\Model;

class nodeBO extends Model
{
    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $docType;

    /**
     * @var bool
     */
    public $isDeleted;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $lastEditTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $nodeId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $nodeName;

    /**
     * @var int
     */
    public $updateTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'createTime'   => 'createTime',
        'docType'      => 'docType',
        'isDeleted'    => 'isDeleted',
        'lastEditTime' => 'lastEditTime',
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
        if (null !== $this->lastEditTime) {
            $res['lastEditTime'] = $this->lastEditTime;
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
        if (isset($map['lastEditTime'])) {
            $model->lastEditTime = $map['lastEditTime'];
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
