<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\CreateExportDeviceStatisticTaskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\CreateExportDeviceStatisticTaskResponseBody\exportStatisticTaskDTO\aiSheetDocumentOpenDTO;
use AlibabaCloud\Tea\Model;

class exportStatisticTaskDTO extends Model
{
    /**
     * @var aiSheetDocumentOpenDTO
     */
    public $aiSheetDocumentOpenDTO;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $taskId;

    /**
     * @var string
     */
    public $taskName;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'aiSheetDocumentOpenDTO' => 'aiSheetDocumentOpenDTO',
        'corpId' => 'corpId',
        'taskId' => 'taskId',
        'taskName' => 'taskName',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aiSheetDocumentOpenDTO) {
            $res['aiSheetDocumentOpenDTO'] = null !== $this->aiSheetDocumentOpenDTO ? $this->aiSheetDocumentOpenDTO->toMap() : null;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return exportStatisticTaskDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aiSheetDocumentOpenDTO'])) {
            $model->aiSheetDocumentOpenDTO = aiSheetDocumentOpenDTO::fromMap($map['aiSheetDocumentOpenDTO']);
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
