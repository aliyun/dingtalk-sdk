<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryRecentListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DentryModel;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryRecentListResponseBody\recentList\team;
use AlibabaCloud\Tea\Model;

class recentList extends Model
{
    /**
     * @description 是否被删除。
     *
     * @var bool
     */
    public $deleted;

    /**
     * @description 节点信息。
     *
     * @var DentryModel
     */
    public $dentry;

    /**
     * @description 如果查询的是访问，那么这里是访问时间；否则就是编辑时间。
     *
     * @var int
     */
    public $recentTime;

    /**
     * @description 小组信息
     *
     * @var team
     */
    public $team;
    protected $_name = [
        'deleted'    => 'deleted',
        'dentry'     => 'dentry',
        'recentTime' => 'recentTime',
        'team'       => 'team',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deleted) {
            $res['deleted'] = $this->deleted;
        }
        if (null !== $this->dentry) {
            $res['dentry'] = null !== $this->dentry ? $this->dentry->toMap() : null;
        }
        if (null !== $this->recentTime) {
            $res['recentTime'] = $this->recentTime;
        }
        if (null !== $this->team) {
            $res['team'] = null !== $this->team ? $this->team->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return recentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deleted'])) {
            $model->deleted = $map['deleted'];
        }
        if (isset($map['dentry'])) {
            $model->dentry = DentryModel::fromMap($map['dentry']);
        }
        if (isset($map['recentTime'])) {
            $model->recentTime = $map['recentTime'];
        }
        if (isset($map['team'])) {
            $model->team = team::fromMap($map['team']);
        }

        return $model;
    }
}
