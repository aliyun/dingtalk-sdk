<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\AnalysisReportResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\AnalysisReportResponseBody\result\cols;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\AnalysisReportResponseBody\result\visualizationSettings;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\undefined;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var cols[]
     */
    public $cols;

    /**
     * @var undefined[][]
     */
    public $listQuery;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string[][]
     */
    public $rows;

    /**
     * @var string
     */
    public $tips;

    /**
     * @var string
     */
    public $title;

    /**
     * @var visualizationSettings
     */
    public $visualizationSettings;
    protected $_name = [
        'cols'                  => 'cols',
        'listQuery'             => 'listQuery',
        'name'                  => 'name',
        'rows'                  => 'rows',
        'tips'                  => 'tips',
        'title'                 => 'title',
        'visualizationSettings' => 'visualizationSettings',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cols) {
            $res['cols'] = [];
            if (null !== $this->cols && \is_array($this->cols)) {
                $n = 0;
                foreach ($this->cols as $item) {
                    $res['cols'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->listQuery) {
            $res['listQuery'] = $this->listQuery;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->rows) {
            $res['rows'] = $this->rows;
        }
        if (null !== $this->tips) {
            $res['tips'] = $this->tips;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->visualizationSettings) {
            $res['visualizationSettings'] = null !== $this->visualizationSettings ? $this->visualizationSettings->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cols'])) {
            if (!empty($map['cols'])) {
                $model->cols = [];
                $n           = 0;
                foreach ($map['cols'] as $item) {
                    $model->cols[$n++] = null !== $item ? cols::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['listQuery'])) {
            if (!empty($map['listQuery'])) {
                $model->listQuery = $map['listQuery'];
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['rows'])) {
            if (!empty($map['rows'])) {
                $model->rows = $map['rows'];
            }
        }
        if (isset($map['tips'])) {
            $model->tips = $map['tips'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['visualizationSettings'])) {
            $model->visualizationSettings = visualizationSettings::fromMap($map['visualizationSettings']);
        }

        return $model;
    }
}
