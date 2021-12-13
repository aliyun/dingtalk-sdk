<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsResponseBody\recentList;

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
    public $lastEditTime;

    /**
     * @description 是否被删除
     *
     * @var bool
     */
    public $isDeleted;
    protected $_name = [
        'nodeId'       => 'nodeId',
        'nodeName'     => 'nodeName',
        'url'          => 'url',
        'lastEditTime' => 'lastEditTime',
        'isDeleted'    => 'isDeleted',
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
        if (null !== $this->lastEditTime) {
            $res['lastEditTime'] = $this->lastEditTime;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
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
        if (isset($map['lastEditTime'])) {
            $model->lastEditTime = $map['lastEditTime'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }

        return $model;
    }
}
