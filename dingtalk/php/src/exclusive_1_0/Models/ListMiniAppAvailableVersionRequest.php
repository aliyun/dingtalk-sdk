<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListMiniAppAvailableVersionRequest extends Model
{
    /**
     * @description 小程序id
     *
     * @var string
     */
    public $miniAppId;

    /**
     * @description 分页数1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 版本类型列表，0-开发版，1-灰度版，2-发布版，3-体验版
     *
     * @var int[]
     */
    public $versionTypeSet;
    protected $_name = [
        'miniAppId'      => 'miniAppId',
        'pageNumber'     => 'pageNumber',
        'pageSize'       => 'pageSize',
        'versionTypeSet' => 'versionTypeSet',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->versionTypeSet) {
            $res['versionTypeSet'] = $this->versionTypeSet;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListMiniAppAvailableVersionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['versionTypeSet'])) {
            if (!empty($map['versionTypeSet'])) {
                $model->versionTypeSet = $map['versionTypeSet'];
            }
        }

        return $model;
    }
}
