<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceNodeResponseBody;

use AlibabaCloud\Tea\Model;

class nodeBO extends Model
{
    /**
     * @description 节点类型
     *
     * @var string
     */
    public $docType;

    /**
     * @description 最后编辑时间
     *
     * @var int
     */
    public $lastEditTime;

    /**
     * @description 节点名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 节点Id
     *
     * @var string
     */
    public $nodeId;

    /**
     * @description 节点打开url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'docType'      => 'docType',
        'lastEditTime' => 'lastEditTime',
        'name'         => 'name',
        'nodeId'       => 'nodeId',
        'url'          => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->docType) {
            $res['docType'] = $this->docType;
        }
        if (null !== $this->lastEditTime) {
            $res['lastEditTime'] = $this->lastEditTime;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nodeId) {
            $res['nodeId'] = $this->nodeId;
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
        if (isset($map['docType'])) {
            $model->docType = $map['docType'];
        }
        if (isset($map['lastEditTime'])) {
            $model->lastEditTime = $map['lastEditTime'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nodeId'])) {
            $model->nodeId = $map['nodeId'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
