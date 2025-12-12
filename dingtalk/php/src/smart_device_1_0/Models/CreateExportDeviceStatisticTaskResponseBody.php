<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\CreateExportDeviceStatisticTaskResponseBody\exportStatisticTaskDTO;
use AlibabaCloud\Tea\Model;

class CreateExportDeviceStatisticTaskResponseBody extends Model
{
    /**
     * @var exportStatisticTaskDTO
     */
    public $exportStatisticTaskDTO;
    protected $_name = [
        'exportStatisticTaskDTO' => 'exportStatisticTaskDTO',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->exportStatisticTaskDTO) {
            $res['exportStatisticTaskDTO'] = null !== $this->exportStatisticTaskDTO ? $this->exportStatisticTaskDTO->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateExportDeviceStatisticTaskResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['exportStatisticTaskDTO'])) {
            $model->exportStatisticTaskDTO = exportStatisticTaskDTO::fromMap($map['exportStatisticTaskDTO']);
        }

        return $model;
    }
}
