<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryItemByUrlResponseBody\space;
use AlibabaCloud\Tea\Model;

class QueryItemByUrlResponseBody extends Model
{
    /**
     * @description 业务类型。可选值：dingpan-云盘中的文档；mainsite-知识库中的文档。
     *
     * @var string
     */
    public $bizType;

    /**
     * @var DentryModel
     */
    public $dentry;

    /**
     * @description 资源类型。可选值有：space-知识库；file-文档；folder-文件夹。
     *
     * @var string
     */
    public $resourceType;

    /**
     * @description 当resourceType为space时，这里会返回知识库信息。
     *
     * @var space
     */
    public $space;
    protected $_name = [
        'bizType'      => 'bizType',
        'dentry'       => 'dentry',
        'resourceType' => 'resourceType',
        'space'        => 'space',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->dentry) {
            $res['dentry'] = null !== $this->dentry ? $this->dentry->toMap() : null;
        }
        if (null !== $this->resourceType) {
            $res['resourceType'] = $this->resourceType;
        }
        if (null !== $this->space) {
            $res['space'] = null !== $this->space ? $this->space->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryItemByUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['dentry'])) {
            $model->dentry = DentryModel::fromMap($map['dentry']);
        }
        if (isset($map['resourceType'])) {
            $model->resourceType = $map['resourceType'];
        }
        if (isset($map['space'])) {
            $model->space = space::fromMap($map['space']);
        }

        return $model;
    }
}
