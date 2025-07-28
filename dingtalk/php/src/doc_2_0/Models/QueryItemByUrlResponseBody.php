<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryItemByUrlResponseBody\space;
use AlibabaCloud\Tea\Model;

class QueryItemByUrlResponseBody extends Model
{
    /**
     * @example mainsite
     *
     * @var string
     */
    public $bizType;

    /**
     * @var DentryModel
     */
    public $dentry;

    /**
     * @example file
     *
     * @var string
     */
    public $resourceType;

    /**
     * @var space
     */
    public $space;
    protected $_name = [
        'bizType' => 'bizType',
        'dentry' => 'dentry',
        'resourceType' => 'resourceType',
        'space' => 'space',
    ];

    public function validate() {}

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
