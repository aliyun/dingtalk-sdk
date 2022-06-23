<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExportPointOpenRequest extends Model
{
    /**
     * @description exportType为1时不需要传此参数，目前仅exportType=3时必须传入此参数,必须为七日内某一天且不能选择当日，格式yyyyMmdd。
     *
     * @var string
     */
    public $exportDate;

    /**
     * @description 导出类型 1为七日内明细，3为七日内某一天榜单，且都不包含当日
     *
     * @var int
     */
    public $exportType;

    /**
     * @description 操作人userId 必须为管理员
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'exportDate' => 'exportDate',
        'exportType' => 'exportType',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->exportDate) {
            $res['exportDate'] = $this->exportDate;
        }
        if (null !== $this->exportType) {
            $res['exportType'] = $this->exportType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExportPointOpenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['exportDate'])) {
            $model->exportDate = $map['exportDate'];
        }
        if (isset($map['exportType'])) {
            $model->exportType = $map['exportType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
