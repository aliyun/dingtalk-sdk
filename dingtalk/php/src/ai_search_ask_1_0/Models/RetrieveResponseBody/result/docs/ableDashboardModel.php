<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\docs;

use AlibabaCloud\Tea\Model;

class ableDashboardModel extends Model
{
    /**
     * @var string
     */
    public $chartName;

    /**
     * @var string
     */
    public $chartType;

    /**
     * @var string
     */
    public $dashboardName;

    /**
     * @var string
     */
    public $data;

    /**
     * @var string
     */
    public $sheetName;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'chartName' => 'chartName',
        'chartType' => 'chartType',
        'dashboardName' => 'dashboardName',
        'data' => 'data',
        'sheetName' => 'sheetName',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->chartName) {
            $res['chartName'] = $this->chartName;
        }
        if (null !== $this->chartType) {
            $res['chartType'] = $this->chartType;
        }
        if (null !== $this->dashboardName) {
            $res['dashboardName'] = $this->dashboardName;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->sheetName) {
            $res['sheetName'] = $this->sheetName;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ableDashboardModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chartName'])) {
            $model->chartName = $map['chartName'];
        }
        if (isset($map['chartType'])) {
            $model->chartType = $map['chartType'];
        }
        if (isset($map['dashboardName'])) {
            $model->dashboardName = $map['dashboardName'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['sheetName'])) {
            $model->sheetName = $map['sheetName'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
