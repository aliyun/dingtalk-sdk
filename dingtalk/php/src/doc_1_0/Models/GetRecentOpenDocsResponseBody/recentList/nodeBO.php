<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentOpenDocsResponseBody\recentList;

use AlibabaCloud\Tea\Model;

class nodeBO extends Model
{
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
     * @description 文档打开url
     *
     * @var string
     */
    public $url;

    /**
     * @description 最后编辑时间
     *
     * @var int
     */
    public $lastOpenTime;

    /**
     * @description 是否被删除
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @description 节点类型
     *
     * @var string
     */
    public $docType;
    protected $_name = [
        'nodeId'       => 'nodeId',
        'nodeName'     => 'nodeName',
        'url'          => 'url',
        'lastOpenTime' => 'lastOpenTime',
        'isDeleted'    => 'isDeleted',
        'docType'      => 'docType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nodeId) {
            $res['nodeId'] = $this->nodeId;
        }
        if (null !== $this->nodeName) {
            $res['nodeName'] = $this->nodeName;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->lastOpenTime) {
            $res['lastOpenTime'] = $this->lastOpenTime;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->docType) {
            $res['docType'] = $this->docType;
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
        if (isset($map['nodeId'])) {
            $model->nodeId = $map['nodeId'];
        }
        if (isset($map['nodeName'])) {
            $model->nodeName = $map['nodeName'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['lastOpenTime'])) {
            $model->lastOpenTime = $map['lastOpenTime'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['docType'])) {
            $model->docType = $map['docType'];
        }

        return $model;
    }
}
