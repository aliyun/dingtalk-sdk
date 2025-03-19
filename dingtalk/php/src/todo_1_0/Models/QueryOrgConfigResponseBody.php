<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOrgConfigResponseBody extends Model
{
    /**
     * @var string
     */
    public $appDisplayStyle;

    /**
     * @var int
     */
    public $createdTime;

    /**
     * @var string[]
     */
    public $homepageCatalogs;

    /**
     * @var int
     */
    public $modifiedTime;

    /**
     * @var int
     */
    public $status;
    protected $_name = [
        'appDisplayStyle' => 'appDisplayStyle',
        'createdTime' => 'createdTime',
        'homepageCatalogs' => 'homepageCatalogs',
        'modifiedTime' => 'modifiedTime',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appDisplayStyle) {
            $res['appDisplayStyle'] = $this->appDisplayStyle;
        }
        if (null !== $this->createdTime) {
            $res['createdTime'] = $this->createdTime;
        }
        if (null !== $this->homepageCatalogs) {
            $res['homepageCatalogs'] = $this->homepageCatalogs;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrgConfigResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appDisplayStyle'])) {
            $model->appDisplayStyle = $map['appDisplayStyle'];
        }
        if (isset($map['createdTime'])) {
            $model->createdTime = $map['createdTime'];
        }
        if (isset($map['homepageCatalogs'])) {
            if (!empty($map['homepageCatalogs'])) {
                $model->homepageCatalogs = $map['homepageCatalogs'];
            }
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
