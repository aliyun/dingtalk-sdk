<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListInspectInfoRequest extends Model
{
    /**
     * @var string[]
     */
    public $deviceUuid;

    /**
     * @description 页码
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 当页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 类型（inspect：巡检，protect：保养）
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'deviceUuid' => 'deviceUuid',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'type'       => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceUuid) {
            $res['deviceUuid'] = $this->deviceUuid;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListInspectInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceUuid'])) {
            if (!empty($map['deviceUuid'])) {
                $model->deviceUuid = $map['deviceUuid'];
            }
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
