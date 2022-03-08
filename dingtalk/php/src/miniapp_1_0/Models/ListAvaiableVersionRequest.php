<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListAvaiableVersionRequest extends Model
{
    /**
     * @var string
     */
    public $bundleId;

    /**
     * @var string
     */
    public $miniAppId;

    /**
     * @var int
     */
    public $pageNum;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @var int[]
     */
    public $versionTypeSet;
    protected $_name = [
        'bundleId'       => 'bundleId',
        'miniAppId'      => 'miniAppId',
        'pageNum'        => 'pageNum',
        'pageSize'       => 'pageSize',
        'versionTypeSet' => 'versionTypeSet',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bundleId) {
            $res['bundleId'] = $this->bundleId;
        }
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->pageNum) {
            $res['pageNum'] = $this->pageNum;
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
     * @return ListAvaiableVersionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bundleId'])) {
            $model->bundleId = $map['bundleId'];
        }
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['pageNum'])) {
            $model->pageNum = $map['pageNum'];
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
