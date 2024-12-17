<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetOrgConfigRequest extends Model
{
    /**
     * @var int
     */
    public $appDisplayStyle;

    /**
     * @var string[]
     */
    public $homepageCatalogs;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'appDisplayStyle'  => 'appDisplayStyle',
        'homepageCatalogs' => 'homepageCatalogs',
        'operatorId'       => 'operatorId',
        'status'           => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appDisplayStyle) {
            $res['appDisplayStyle'] = $this->appDisplayStyle;
        }
        if (null !== $this->homepageCatalogs) {
            $res['homepageCatalogs'] = $this->homepageCatalogs;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetOrgConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appDisplayStyle'])) {
            $model->appDisplayStyle = $map['appDisplayStyle'];
        }
        if (isset($map['homepageCatalogs'])) {
            if (!empty($map['homepageCatalogs'])) {
                $model->homepageCatalogs = $map['homepageCatalogs'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
